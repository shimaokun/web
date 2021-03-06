/**
 * Created by mk on 2018/7/28.
 */
var prepage=5;
var page=1;
var pages=0;
var comments=[];
$('#messageBtn').on('click',funcion(){
    $.ajax({
        type:'POST',
        url:'/api/comment/post',
        data:{
            contentid:$('#contentId').val(),
            content:$('#messageContent').val()
        },
        success:function(responseData){
            $('#messageContent').val('');
            comments=responseData.data.comments.reverse();
            renderComment();
        }
    })t
});
//每次页面重载时获取文章评论
$.ajax({
    url:'/api/comment',
    data:{
        contentid:$('#contentId').val()
    },
    success:function(responseData){
        comments=responseData.data.reverse();
        renderComment();
    }
});
$('.pager').delegate('a','click',function(){
    if($(this).parent().hasClass('previous')){
        page--;
    }else{
        page++;
    }
    renderComment();
});


function renderComment(){
    $('#messageCount').html(comments.length);
    pages=Math.max(Math.ceil(comments.length/prepage),1);
    var start=Math.max(0,(page-1)*prepage);
    var end=Math.min(start+prepage,comments.length);
    var $lis=$('.pager li');
    $lis.eq(1).html(page+'/'+pages);
    if(page<=1){
        page=1;
        $lis.eq(0).html('<span>没有上一页</span>');
    }else{
        $lis.eq(0).html('<a href="javascript:;">上一页</a>');
    }
    if(page>=pages){
        page=pages;
        $lis.eq(2).html('<span>没有下一页</span>');
    }else{
        $lis.eq(2).html('<a href="javascript:;">下一页</a>');
    }
    if(comments.length==0){
        $('.messageList').html('<div class="messageBox"><p>还没有评论</p></div>');
    }else{
        var html='';
        for(var i=start;i<end;i++){
            html+=' <div class="messageBox">'+
                '<p class="name clear"><span class="fl">'+comments[i].username+'</span><span class="fr">'+formatData(comments[i].postTime)+'</span></p><p>'+comments[i].content+'</p>'+
                '</div>';
        }
        $('.messageList').html(html);
    }

}

function formatData(d){
    var date1=new Date(d);
    return date1.getFullYear()+'-'+(date1.getMonth()+1)+'-'+date1.getDate()+' '+date1.getHours()+':'+date1.getMinutes()+':'+date1.getSeconds();
}