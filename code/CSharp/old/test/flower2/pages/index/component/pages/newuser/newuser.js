Page({

  /**
   * 页面的初始数据
   */
  data: {
    txtname:"请输入用户名",
    txtiphone: "请输入手机号",
    txtyzm:"请输入验证码",
    txtpwd:"请输入密码",
    txtpwd2:"请再次输入密码",
    txtXieyi:"<<商家注册协议>>",
    YzmValue:"获取验证码",
    items: [
      { name: 'word', value: '我阅读并同意' },
    ]
  },
  /* 自定义函数 */
  checkboxChange: function (e) {
    console.log('checkbox发生change事件，携带value值为：', e.detail.value)
  },

  viewXieyi1:function(){
    wx.navigateTo({
      url:'../agreement/agreement',
    })

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    
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