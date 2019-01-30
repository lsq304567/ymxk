//login.js
//var app=GetApp()
Page({

  /**
   * 页面的初始数据
   */
  data: {
    txtname:'请输入手机号',
    txtpwd:'(6到16位数字或密码)'
  },

  bindViewTap: function () {
    wx.navigateTo({
      url: '../newuser/newuser',
      success: function (res) {
        // success  
        console.log(成功);
      },
      fail: function () {
        // fail  
        console.log('sksdfksjfksjf');
      },
      complete: function () {
        // complete  
      }  
    })
  },

  bindForgot:function(){
    wx.redirectTo({
      url: '../forgot/forgot',
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

