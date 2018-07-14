<template>
  <div id="translateOutput">
    <h2 class="tlt">{{translatedText}}</h2>
  </div>
</template>

<script>


export default {
  name: 'translateOutput',
  props:[
  "translatedText"
  ]
  
}

</script>

<style>
#translateOutput{
  width:500px;
  height:100px;
  background-color:#3c3c3c;
  position:relative;
  margin:0 auto;
  color:#ffffff;
}
</style>
