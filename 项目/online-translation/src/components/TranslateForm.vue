<template>
  <div class="row" id="translateForm">
  <div class="col-md-6 col-md-offset-3">
   <form class="form1" v-on:submit="formSubmit">
   	   <input class="txt" type="text" v-model="textToTranslate" placeholder="输入需要翻译的内容">
   	<select class="sel" v-model="language">
   		<option value="en">English</option>
   		<option value="ru">Russian</option>
   		<option value="ko">Korean</option>
   		<option value="ja">Janpenese</option>
   	</select>
   	<input type="submit" value="翻译" class="btn">
   </form>
   </div>
  </div>
</template>

<script>


export default {
  name: 'translateForm',
  data:function(){
  	return{
  		textToTranslate:"",
  		language:""
  	}
  },
  methods:{
  	formSubmit:function(e){
  		//alert(this.textToTranslate);
  		this.$emit("formSubmit",this.textToTranslate,this.language);
  		e.preventDefault();
  	}
  }
}

</script>

<style>
.row{
	background-color:#3c3c3c;
	width:500px;
	height:100px;
	position:relative;
  margin:0 auto;
}
.form1{
	position:absolute;
	top:35px;
	left:75px;
}
.txt{
	height:25px;
	width:180px;
	border-top-left-radius: 20px;
	border-bottom-left-radius: 20px;
	border:2px solid black;
}
.sel{
  height:31px;
  margin-left:-5px;
  border:2px solid black;
}
.btn{
  border:2px solid black;
  margin-left:-5px;
	font-size:16px;
	line-height:16px;
	color:#000000;
	background-color:#8deeee;
	width:75px;
	height:30px;
	 border-top-right-radius: 20px;
  border-bottom-right-radius: 20px;
  position:absolute;
  margin-top:0.5px;

}
</style>
