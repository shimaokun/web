/**
 * Created by mk on 2018/7/24.
 */
//加载模块
var express=require('express');
//加载模板处理模块
var swig=require('swig');
//加载数据库模块
var mongoose=require('mongoose');
//处理post提交过来的数据
var bodyParser=require('body-parser');
//加载cookies模块
var Cookies=require('cookies');
//创建应用
var app=express();

var User=require('./models/User');

//设置静态文件托管
app.use('/public',express.static(__dirname+'/public'));
//配置应用模板
//定义当前应用的模板引擎,html为模板引擎名称及文件后缀，renderFile为解析处理模板的方法
app.engine('html',swig.renderFile);
//views为固定参数，./views为文件路径
app.set('views','./views');
//注册所使用的模板引擎,view engine为固定参数，html与app.engine中所使用模板引擎名称一致
app.set('view engine','html');
//取消模板缓存
swig.setDefaults({cache:false});
//bodyparse设置
app.use(bodyParser.urlencoded({extended:true}));
//设置cookies
app.use(function(req,res,next){
    req.cookies=new Cookies(req,res);
    //解析登陆用户的信息
    req.userInfo={};
    if(req.cookies.get('userInfo')){
        try{
            req.userInfo= JSON.parse(req.cookies.get('userInfo'));
            //获取登录类型
            User.findById(req.userInfo._id).then(function(userInfo){
                req.userInfo.isAdmin=Boolean(userInfo.isAdmin);
                next();
            })
        }catch(e){}
    }else{
        next();
    }
});
//根据不同功能划分模块
//后台模块
app.use('/admin',require('./routers/admin'));
//api模块
app.use('/api',require('./routers/api'));
//前台模块
app.use('/',require('./routers/main'));

//创建监听请求
mongoose.connect('mongodb://localhost:27017/log',{ useNewUrlParser: true },function(err){
    if(err){b
        console.log('数据库连接失败')
    }else{
        console.log('数据库连接成功');
        app.listen(8888);
    }
});
