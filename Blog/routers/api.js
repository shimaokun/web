/**
 * Created by mk on 2018/7/24.
 */
var express=require('express');
var router=express.Router();
var User=require('../models/User');
var Content=require('../models/Content');

//返回统一格式
var responseData;
router.use(function(req,res,next){
    responseData={
        code:0,
        message:''
    }
    next();
});
router.post('/user/register',function(req,res,next){
    var username=req.body.username;
    var password=req.body.password;
    var repassword=req.body.repassword;
    if(username ==''){
        responseData.code=1;
        responseData.message='用户名不能为空';
        res.json(responseData);
        return;
    }
    if(password == ''){
        responseData.code=2;
        responseData.message='密码不能为空';
        res.json(responseData);
        return;
    }
    if(repassword!=password){
        responseData.code=3;
        responseData.message='两次密码不一致';
        res.json(responseData);
        return;
    }
    User.findOne({
        username:username
    }).then(function(userInfo){
       if(userInfo){
           responseData.code=4;
           responseData.message='该用户名已被注册';
           res.json(responseData);
           return;
       }
        var user=new User({
            username:username,
            password:password
        });
        return user.save();
    }).then(function(newUserInfo){
        responseData.message='注册成功';
        res.json(responseData);
    });

});

router.post('/user/login',function(req,res){
    var username=req.body.username;
    var password=req.body.password;
    if(username==''||password==''){
        responseData.code=1;
        responseData.message='用户名或密码不能为空';
        res.json(responseData);
        return;
    }
    User.findOne({
        username:username,
        password:password
    }).then(function(userInfo){
        if(!userInfo){
            responseData.code=2;
            responseData.message='用户名或密码错误';
            res.json(responseData);
            return;
        }
        responseData.message='登录成功';
        responseData.userInfo={
            _id:userInfo._id,
            username:userInfo.username
        }
        req.cookies.set('userInfo',JSON.stringify({
            _id:userInfo._id,
            username:userInfo.username
        }));
        res.json(responseData);
        return;
    })
});

router.get('/user/logout',function(req,res){
    req.cookies.set('userInfo',null);
    responseData.message='退出';
    res.json(responseData);
});
//获取指定文章评论
router.get('/comment',function(req,res){
    var contentId=req.query.contentid||'';
    Content.findOne({
        _id:contentId
    }).then(function(content){
        responseData.data=content.comments;
        res.json(responseData);
    })
})
//评论提交
router.post('/comment/post',function(req,res){
    //内容id
    var contentId=req.body.contentid||'';
    var postData={
        username:req.userInfo.username,
        postTime:new Date(),
        content:req.body.content
    };
    //查询当前内容信息
    Content.findOne({
        _id:contentId
    }).then(function(content){
        content.comments.push(postData);
        return content.save();
    }).then(function(newContent){
        responseData.message='评论成功';
        responseData.data=newContent;
        res.json(responseData);
    });
});
module.exports=router;