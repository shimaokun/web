/**
 * Created by mk on 2018/7/25.
 */
var mongoose=require('mongoose');
var usersSchema=require('../schemas/users');
module.exports=mongoose.model('User',usersSchema);