/**
 * Created by mk on 2018/7/24.
 */
var mongoose=require('mongoose');
//内容表
module.exports=new mongoose.Schema({
    //关联字段 内容分类id
    category:{
        //类型
        type:mongoose.Schema.Types.ObjectId,
        //引用
        ref:'Category'
    },
    title:String,
    //关联字段 用户id
    user:{
        //类型
        type:mongoose.Schema.Types.ObjectId,
        //引用
        ref:'User'
    },
    //添加时间
    addTime:{
        type:Date,
        default:new Date()
    },
    //阅读量
    views:{
       type:Number,
        default:0
    },
    description:{
        type:String,
        default:''
    },
    content:{
        type:String,
        default:''
    },
    //评论字段
    comments:{
        type:Array,
        default:[]
    }
});