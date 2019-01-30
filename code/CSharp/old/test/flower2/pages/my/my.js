//js
var app = getApp()
  Page({
  /**
   * 页面的初始数据
   */
  data: {
    userInfo:{},
    userListInfo: [{
      id:1,
      icon: '/images/zhanghaoxinxi.png',
      text: '账号信息',
      content: 'mya',
    }, {
      id: 2,
      icon: '/images/lianxikefu.png',
      text: '联系客服',
      content: 'myb',
      }, {
      id: 3,
      icon: '/images/guanyuwomen.png',
      text: '关于我们',
      content: 'myc',
    }]  
  },
 
//跳转页面
  readArticle: function (e){
   var $data = e.currentTarget.dataset;
    wx.navigateTo({
      url:$data-content,
    })
  },
  /**
   * 生命周期函数--监听页面加载
   */
   onLoad: function (options) {
    var that = this
    //调用应用实例的方法获取全局数据  
    app.getUserInfo(function (userInfo) {
      //更新数据  
      that.setData({
       userInfo: userInfo
      })
    })  
  },
   
  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {
    
  },
  

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {
   
  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {
    
  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {
    
  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {
    
  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {
    
  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {
  }
})