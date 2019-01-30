Page({
  data:{
    text:"这里是内容",
    btnText:"remove",
    show:false,
    news:['aaa','bbb','ccc'],
  },
  onLoad: function (options){
    //页面初始化 options为页面跳转所带来的参数
  },
  onReady: function (){
    //页面渲染完成
  },
  onShow: function (){
    //页面显示
  },
  onHide: function (){
    //页面隐藏
  },
  onUnload:function(){
    //页面关闭
  },
  remove:function(){
    console.log("按钮被点击了")
    var isShow=this.data.show;
    console.log("isShow:"+isShow),
    this.setDate({text:"这是一个新的内容"},show=!isShow)
  }
})