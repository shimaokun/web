/**
 * Created by mk on 2018/7/24.
 */
var express=require('express');
var router=express.Router();
var User=require('../models/User');
var Category=require('../models/Category');
var Content=require('../models/Content');

router.use(function(req,res,next){
    if(!req.userInfo.isAdmin){
        res.send('只有管理员才有权限！');
        return;
    }
    next();
});
//首页
router.get('/',function(req,res,next){
    res.render('admin/index',{
        userInfo:req.userInfo
    });
});
//用户管理
router.get('/user',function(req,res){
    //读取用户数据
    //limit(n)限制读取n条数据条目
    //skip(n)忽略前n条数据条目
    var page=Number(req.query.page||1);
    var limit=4;
    var pages=0;
    User.count().then(function(count){
        pages=Math.ceil(count/limit);
        page=Math.min(page,pages);
        page=Math.max(page,1);
        var skip=(page-1)*limit;
        User.find().limit(limit).skip(skip).then(function(user){
            res.render('admin/user_index',{
                userInfo:req.userInfo,
                users:user,
                count:count,
                pages:pages,
                limit:limit,
                page:page
            });
        });
    });
});
//分类首页
router.get('/category',function(req,res){
    var page=Number(req.query.page||1);
    var limit=4;
    var pages=0;
    Category.count().then(function(count){
        pages=Math.ceil(count/limit);
        page=Math.min(page,pages);
        page=Math.max(page,1);
        var skip=(page-1)*limit;
        Category.find().sort({_id:-1}).limit(limit).skip(skip).then(function(categories){
            res.render('admin/category_index',{
                userInfo:req.userInfo,
                categories:categories,
                count:count,
                pages:pages,
                limit:limit,
                page:page
            });
        });
    });
});
//添加分类
router.get('/category/add',function(req,res){
    res.render('admin/category_add',{
        userInfo:req.userInfo
    });
});
//分类保存
router.post('/category/add',function(req,res){
    var name=req.body.name||'';
    if(name==''){
        res.render('admin/error',{
            userInfo:req.userInfo,
            message:'名称不能为空'
        });
        return;
    }
    //是否存在同名
    Category.findOne({
        name:name
    }).then(function(rs){
        if(rs){
            //存在
            res.render('admin/error',{
                userInfo:req.userInfo,
                message:'分类已经存在'
            })
            return Promise.reject();
        }else{
            //不存在
            return new Category({
                name:name
            }).save();
        }
    }).then(function(newCategory){
        res.render('admin/success',{
            userInfo:req.userInfo,
            message:'分类保存成功',
            url:'/admin/category'
        });
    })
});
//分类修改
router.get('/category/edit',(req, res, next)=>{
    let _id = req.query.id || '';
    Category.findOne({_id}).then((category)=>{
        if(!category){
            res.render('admin/error',{
                userInfo: req.userInfo,
                message: '分类名称不存在'
            });
        } else {
            res.render('admin/category_edit',{
                userInfo: req.userInfo,
                category
            });
        }
    });
});

router.post('/category/edit',(req, res, next)=>{
    let _id = req.query.id || '';
    let name = req.body.name || '';
    Category.findOne({_id}).then((category)=>{
        if(!category){
            res.render('admin/error',{
                userInfo: req.userInfo,
                message: '分类名称不存在'
            });
            return Promise.reject();
        } else {
            if(name == category.name){
                res.render('admin/success',{
                    userInfo: req.userInfo,
                    message: '分类修改成功',
                    url: '/admin/category'
                });
                return Promise.reject();
            } else {
                return Category.findOne({_id: {$ne: _id}, name})
            }
        }
    }).then((sameCategory)=>{
        if(sameCategory){
            res.render('admin/error',{
                userInfo: req.userInfo,
                message: '数据库中存在同名分类'
            });
            return Promise.reject();
        } else {
            return Category.update({_id}, {name});
        }
    }).then(()=>{
        res.render('admin/success',{
            userInfo: req.userInfo,
            message: '分类修改成功',
            url: '/admin/category'
        });
    }).catch(()=>{});
});

//分类删除
router.get('/category/delete',(req, res, next)=>{
    let _id = req.query.id;
    Category.remove({_id}).then((delCategory)=>{
        res.render('admin/success',{
            userInfo: req.userInfo,
            message: '删除分类成功',
            url: '/admin/category'
        });
    });
});

//内容首页
router.get('/content',function(req,res){
    var page=Number(req.query.page||1);
    var limit=4;
    var pages=0;
    Content.count().then(function(count){
        pages=Math.ceil(count/limit);
        page=Math.min(page,pages);
        page=Math.max(page,1);
        var skip=(page-1)*limit;
        Content.find().sort({_id:-1}).limit(limit).skip(skip).populate(['category','user']).sort({
            addTime:-1
        }).then(function(contents){

            res.render('admin/content_index',{
                userInfo:req.userInfo,
                contents:contents,
                count:count,
                pages:pages,
                limit:limit,
                page:page
            });
        });
    });
});
//内容添加
router.get('/content/add',function(req,res){
    Category.find().sort({_id:-1}).then(function(categories){
        res.render('admin/content_add',{
            userInfo:req.userInfo,
            categories:categories
        })
    });
});
//内容保存
router.post('/content/add',function(req,res){
    if( req.body.category==''){
        res.render('admin/error',{
            userInfo:req.userInfo,
            message:'内容分类不能为空'
        })
        return;
    }

    if(req.body.title==''){
        res.render('admin/error',{
            userInfo:req.userInfo,
            message:'内容标题不能为空'
        })
        return;
    }
    //保存数据
    new Content({
        category:req.body.category,
        title:req.body.title,
        user:req.userInfo._id.toString(),
        description:req.body.description,
        content:req.body.content
    }).save().then(function(rs){
        res.render('admin/success',{
            userInfo:req.userInfo,
            message:'内容保存成功',
            url:'/admin/content'
        })

    })
});
//修改内容
router.get('/content/edit',function(req,res){
    var id=req.query.id||'';
    var categories=[];
    Category.find().sort({_id:-1}).then(function(rs){
        categories=rs;
        return Content.findOne({
            _id:id
        }).populate('category');
    }).then(function(content){
        if(!content){
            res.render('admin/error',{
                userInfo:req.userInfo,
                message:'指定内容不存在'
            });
            return Promise.reject();
        }else{
            res.render('admin/content_edit',{
                userInfo:req.userInfo,
                categories:categories,
                content:content
            })
        }
    });

});
//内容保存
router.post('/content/edit',function(req,res){
    var id=req.query.id||'';
    if( req.body.category==''){
        res.render('admin/error',{
            userInfo:req.userInfo,
            message:'内容分类不能为空'
        })
        return;
    }

    if(req.body.title==''){
        res.render('admin/error',{
            userInfo:req.userInfo,
            message:'内容标题不能为空'
        })
        return;
    }
    Content.update({
        _id:id
    },{
        category:req.body.category,
        title:req.body.title,
        description:req.body.description,
        content:req.body.content
    }).then(function(){
        res.render('admin/success',{
            userInfo:req.userInfo,
            message:'内容保存成功',
            url:'/admin/content/edit?id='+id
        })
    });
});
//内容删除
router.get('/content/delete',function(req,res){
    var id=req.query.id||'';
    Content.remove({
        _id:id
    }).then(function(){
        res.render('admin/success',{
            userInfo:req.userInfo,
            message:'删除成功',
            url:'/admin/content'
        });
    });
});
module.exports=router;