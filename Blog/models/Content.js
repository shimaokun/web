/**
 * Created by mk on 2018/7/25.
 */
var mongoose=require('mongoose');
var contentsSchema=require('../schemas/content');
module.exports=mongoose.model('Content',contentsSchema);