//index.js
Page({
  data: {
    imgUrls: [
      'https://gss3.bdstatic.com/-Po3dSag_xI4khGkpoWK1HF6hhy/baike/c0%3Dbaike80%2C5%2C5%2C80%2C26/sign=357dab8e4ded2e73e8e48e7ee668caee/a2cc7cd98d1001e93a065005bf0e7bec54e79785.jpg',
      'https://gss0.bdstatic.com/-4o3dSag_xI4khGkpoWK1HF6hhy/baike/crop%3D0%2C113%2C1024%2C677%3Bc0%3Dbaike116%2C5%2C5%2C116%2C38/sign=e1aca61b3001213fdb7c149c69d71ae0/29381f30e924b899c5bdebfa67061d950b7bf66b.jpg',
      'https://gss3.bdstatic.com/-Po3dSag_xI4khGkpoWK1HF6hhy/baike/c0%3Dbaike92%2C5%2C5%2C92%2C30/sign=adce509b356d55fbd1cb7e740c4b242f/9825bc315c6034a8d58684c4c31349540923760a.jpg'
    ],
    indicatorDots: true,
    autoplay: true,
    interval: 3000,
    duration: 1000,
    navItems: [
      {
        name: '商品管理',
        url: 'dishes'
      },
      {
        name: '添加商品',
        url: 'take',
        isSplot: true
      },
      {
        name: '订单管理',
        url: 'takea'
      },
      {
        name: '评价管理',
        url: 'takeb'
      },
      {
        name: '交易汇总',
        url: 'takec',
        isSplot: true
      },
      {
        name: '个人信息',
        url: 'taked'
      }
    ]
  },
  onLoad: function () {
    console.log('onLoad')
  }

})