/**
 * Created by mk on 2018/7/25.
 */
var mongoose=require('mongoose');
var categoriesSchema=require('../schemas/categories');
module.exports=mongoose.model('Category',categoriesSchema);