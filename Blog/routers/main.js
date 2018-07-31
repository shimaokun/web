/**
 * Created by mk on 2018/7/24.
 */
var express=require('express');
var router=express.Router();
var Content=require('../models/Content');
var Category=require('../models/Category');
var data;
//通用数据
router.use(function(req,res,next){
    data={
        userInfo:req.userInfo,
        categories:[]
    }
    Category.find().then(function(categories){
        data.categories=categories;
        next();
    });
});
//首页
router.get('/',function(req,res,next){
    data.category=req.query.category||'';
    data.count=0;
    data.page=Number(req.query.page||1);
    data.limit=4;
    data.pages=0;
    var where={};
    if(data.category){
        where.category=data.category
    }
    //读取分类信息
    Content.where(where).count().then(function(count){
       data.count=count;
       data.pages=Math.ceil(data.count/data.limit);
       data.page=Math.min(data.page,data.pages);
       data.page=Math.max(data.page,1);
       var skip=(data.page-1)*data.limit;

       return Content.where(where).find().limit(data.limit).skip(skip).populate(['category','user']).sort({
           addTime:-1
       });
       }).then(function(contents){
       data.contents=contents;
       res.render('main/index',data);
   })

});

router.get('/view',function(req,res){
    var contentId=req.query.contentid||'';
    Content.findOne({
        _id:contentId
    }).then(function(content){
        data.content=content;
        content.views++;
        content.save();
        res.render('main/view',data);
    });
});
module.exports=router;