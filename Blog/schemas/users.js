/**
 * Created by mk on 2018/7/24.
 */
var mongoose=require('mongoose');
//用户表
module.exports=new mongoose.Schema({
    username:String,
    password:String,
    isAdmin:{
        type:Boolean,
        default:false
    }
});