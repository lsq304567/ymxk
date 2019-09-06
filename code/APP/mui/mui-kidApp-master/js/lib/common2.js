//api连接前缀
var APP_DOMAIN = '';

//为true输出日志
var debug = true;


//页面回弹
var sw = document.getElementsByClassName(".mui-scroll-wrapper.scroll");
if (sw) {
  mui('.mui-scroll-wrapper.scroll').scroll();
}

//本地不可清除基础数据
var baseStorage;
//本地临时数据
var temporaryStorage;
//本地登录用户
var storageUser;
//本地用户地址信息
var storageLocation;
//单例 本地存储策略
var kidstorage = (function () {
  //单例数组
  var instancearr = [];

  function _getInstance(keyname) {
    var item;
    for (var i = 0; i < instancearr.length; i++) {
      item = instancearr[i];
      if (item.keyname == keyname) {
        return item.obj;
      }
    }
  }

  function setInstance(_keyname, _obj) {
    var item, oldobj;
    for (var i = 0; i < instancearr.length; i++) {
      item = instancearr[i];
      if (item.keyname == _keyname) {
        item = _obj;
      }
    }
    if (oldobj == undefined || oldobj == null) {
      instancearr.push({
        keyname: _keyname,
        obj: _obj
      })
    }
  }

  //单例方法
  function singlekidstorage(_keyname) {
    var self = this;
    self.keyname = _keyname;
    self.data = {};
    self.log = function () {
      var str = plus.storage.getItem(self.keyname);
      if (self.keyname.indexOf("base") == 0) {
        log("本地不可清除基础数据=" + str);
      } else
        log("本地可清除数据=" + str);
    };
    self.save = function () {
      plus.storage.setItem(self.keyname, JSON.stringify(self.data));
    };
    self.clear = function () {
      plus.storage.removeItem(self.keyname);
    };
    self.setItem = function (key, field, val) {
      var str = plus.storage.getItem(self.keyname);
      var obj = JSON.parse(str || "{}");
      if (str == undefined || str == "" || str == "{}") {
        plus.storage.setItem(self.keyname, JSON.stringify(obj));
      }
      var obj1 = obj[key];
      if (!obj1) {
        obj[key] = {};
      }
      if (field != undefined) { //属性名
        obj[key][field] = val;
        //alert(key + "|" + field + "|" + val)
      } else
        obj[key] = val;
      self.data = obj;
      //log(JSON.stringify(self.data));
      //alert(JSON.stringify(self.data))
      self.save();
    };
    self.getItem = function (key, field) {
      var str = plus.storage.getItem(self.keyname);
      var obj = JSON.parse(str || "{}");
      if (str == undefined || str == "" || str == "{}") {
        return null;
      }
      var obj1 = obj[key];
      if (obj1) {
        if (field != undefined) { //属性名
          return obj[key][field];
        } else
          return obj[key];
      }
      return null;
    };
    self.removeItem = function (key, field) {
      var str = plus.storage.getItem(self.keyname);
      var obj = JSON.parse(str || "{}");
      if (str == undefined || str == "" || str == "{}") {
        return null;
      }
      if (field != undefined) { //属性名
        delete obj[key][field];
      } else
        delete obj[key];
      self.data = obj;
      self.save();
    }
  }
  return {
    getInstance: function (_keyname) { //获取单例对象
      //单例实例
      var instance = _getInstance(_keyname);
      if (instancearr === undefined || instance == undefined) {
        //log("又一个")
        instance = new singlekidstorage(_keyname);
        setInstance(_keyname, instance);
      }
      return instance;
    }
  };
})();
//所有缓存初始化
var storage = {
  init: function () {

    //本地不可清除基础数据
    baseStorage = kidstorage.getInstance("baseStorageDate");
    //本地临时数据
    temporaryStorage = kidstorage.getInstance("temporaryStorageDate");
    //本地登录用户
    storageUser = kidstorageuser.getInstance();
    //本地用户地址信息
    storageLocation = kidstoragelocation.getInstance();
  }
}
//单例 登录用户本地存储策略
var kidstorageuser = (function () {
  var keyname = 'user'; //缓存key
  var keyname_uid = "id",
    keyname_nickname = "nickname",
    keyname_realname = "realname",
    keyname_username = "username",
    keyname_imgurl = "imgurl",
    keyname_signature = "signature",
    keyname_msgnoreadcount = "msgnoreadcount",
    keyname_mobile = "mobile",
    keyname_version = "version";
  //单例方法
  function singlekidstorageuser() {
    var self = this;
    init(self);
    self.log = function () {
      log(JSON.stringify(self));
    };
    self.login = function (data) { //登录成功保存数据
      var args = {
        id: data.PlayerId,
        username: data.Mobile,
        mobile: data.Mobile,
        nickname: data.NickName,
        imgurl: data.ImgUrl || "../../images/defuser.jpg",
        signature: data.SelfdomSign,
        //cityid:data.CityId
      }
      self.refreshUserName(args.username) //单独设置登录名
      self.refreshMobile(args.mobile) //单独设置手机
      self.refreshNickName(args.nickname); //单独设置昵称
      baseStorage.setItem(keyname, undefined, args);
      init(self);
      //appPage.closeAllPage();
      //通知用户中心页，登录了
      //			var backid = "my/user.html";
      //			var backpage = plus.webview.getWebviewById(backid);
      //			if(backpage) {
      //				mui.fire(backpage, 'loginIn')
      //			}
    };
    self.loginOut = function () { //登出清空数据
      baseStorage.removeItem(keyname);
      kidstoragesearchhistory.clear();
      init(self);
      appPage.closeAllPage();
      //通知用户中心页，登出了
      //			var backid = "my/user.html";
      //			var backpage = plus.webview.getWebviewById(backid);
      //			if(backpage) {
      //				mui.fire(backpage, 'loginOut')
      //			}
    };
    self.refreshField = function (field, val) {
      if (field == keyname_signature) {
        self.refreshSignature(val);
      } else if (field == keyname_imgurl) {
        self.refreshImgUrl(val);
      } else if (field == keyname_mobile) {
        self.refreshMobile(val);
      } else if (field == keyname_realname) {
        self.refreshRealName(val);
      }
      //			else if(field == keyname_imgurl) {
      //				self.refreshImgUrl(val);
      //			} else if(field == keyname_imgurl) {
      //				self.refreshImgUrl(val);
      //			} else if(field == keyname_imgurl) {
      //				self.refreshImgUrl(val);
      //			} else if(field == keyname_imgurl) {
      //				self.refreshImgUrl(val);
      //			} else if(field == keyname_imgurl) {
      //				self.refreshImgUrl(val);
      //			}

    };
    self._refreshField = function (field, val) {
      baseStorage.setItem(keyname, field, val);
      init(self);
    };
    self.refreshVersion = function (val) {
      baseStorage.setItem(keyname_version, undefined, val); //单独设置版本
      self.Version = baseStorage.getItem(keyname_version) || "";
    };
    //刷新登录名
    self.refreshUserName = function (val) {
      baseStorage.setItem(keyname_username, undefined, val); //单独设置登录名
      self.UserName = baseStorage.getItem(keyname_username) || "";
    };

    //刷新昵称
    self.refreshNickName = function (val) {
      baseStorage.setItem(keyname_nickname, undefined, val); //单独设置登录名
      self.NickName = baseStorage.getItem(keyname_nickname) || "";

    };
    //刷新真实姓名
    self.refreshRealName = function (val) {
      self._refreshField(keyname_realname, val);
    };
    //刷新头像
    self.refreshImgUrl = function (val) {
      self._refreshField(keyname_imgurl, val);

      //刷新页面显示
      var user_page = plus.webview.getWebviewById("my/user.html");
      //var myinfo_page = plus.webview.getWebviewById("my/myInfo.html");
      if (user_page) {
        mui.fire(user_page, 'initPage')
      }
      //			if(myinfo_page) {
      //				mui.fire(myinfo_page, 'initPage')
      //			}

    };
    //下载头像
    self.downloadImg = function (url) {

      //			plus.io.requestFileSystem(plus.io.PRIVATE_DOC, function(fs) {
      //				log("fsname=" + fs.name);
      //				// 创建读取目录信息对象
      //				var directoryReader = fs.root.createReader();
      //				directoryReader.readEntries(function(entries) {
      //					var entry, headimgreader, headimgentries, headentry;
      //					for(var i = 0; i < entries.length; i++) {
      //						entry = entries[i];
      //						log("i name="+entry.name)
      //						if(entry.name == "headimg") {
      //							headimgreader = entry.createReader();
      //							headimgreader.readEntries(function(headimgentries) {
      //								for(var j = 0; j < headimgentries.length; j++) {
      //									headentry = headimgentries[j];
      //									log(headentry.name);
      //									headentry.remove();
      //								}
      //							});
      //							break;
      //						}
      //
      //						//entry.remove();
      //					}
      //
      //
      //				}, function(e) {
      //					alert("Read entries failed: " + e.message);
      //				});
      //			}, function(e) {
      //				alert("Request file system failed: " + e.message);
      //			});

      plus.downloader.createDownload(url, {
        filename: "_doc/headimg/"
      }, function (d, status) {
        if (status == 200) {
          plus.io.resolveLocalFileSystemURL(d.filename, function (entry) {
            log("下载头像成功：" + entry.toLocalURL());
            self.refreshImgUrl(entry.toLocalURL()); //路径刷新为本地图片
            self.log();
          });
        } else {

        }
      }).start();
    }
    //刷新签名
    self.refreshSignature = function (val) {
      self._refreshField(keyname_signature, val);

    };
    //刷新手机号
    self.refreshMobile = function (val) {
      baseStorage.setItem(keyname_mobile, undefined, val); //单独设置登录名
      self.Mobile = baseStorage.getItem(keyname_mobile) || "";
    };
  }

  function init(_self) {
    _self.UId = baseStorage.getItem(keyname, keyname_uid) || 0;
    _self.Mobile = baseStorage.getItem(keyname_mobile) || "";
    _self.UserName = baseStorage.getItem(keyname_username) || "";
    _self.NickName = baseStorage.getItem(keyname_nickname) || "";
    _self.RealName = baseStorage.getItem(keyname, keyname_realname) || "";
    _self.ImgUrl = baseStorage.getItem(keyname, keyname_imgurl) || "";
    _self.Signature = baseStorage.getItem(keyname, keyname_signature) || "";
    _self.Version = baseStorage.getItem(keyname_version) || "";
    _self.IsLogin = _self.UId > 0;
  }
  //单例实例
  var instance;

  //返回对象
  return {
    getInstance: function (args) {
      //if(instance === undefined) {
      //log("一个心得")
      instance = new singlekidstorageuser(args);
      //}
      return instance;
    },

  };
})();
//用户位置
var kidstoragelocation = (function () {
  var keyname = 'location'; //缓存key
  var keyname_lon = "lon",
    keyname_lat = "lat",
    keyname_province = "province",
    keyname_city = "city",
    keyname_district = "district",
    keyname_addresses = "addresses",
    keyname_timestamp = "timestamp",
    keyname_position = "position",
    keyname_cityid = "cityid",
    againNum = 0;
  //单例方法
  function singlekidstoragelocation() {
    var self = this;
    init(self);
    self.log = function () {
      log(JSON.stringify(self));
    };
    //刷新缓存中值
    self.refreshData = function (data) {
      if (!data || !data.coords || !data.address) {
        return;
      }
      var lon = data.coords.longitude,
        lat = data.coords.latitude,
        province = data.address.province || "",
        city = data.address.city || "",
        district = data.address.district || "",
        addresses = data.addresses,
        timespan = data.timestamp,
        position = data;

      self.Lon = lon || "";
      self.Lat = lat || "";
      self.Province = province || "";
      self.City = city || "";
      self.District = district || "";
      self.Addresses = addresses || "";
      self.Position = JSON.stringify(position) || "";
      self.Timestamp = timespan || "";

      if (city) {
        //刷新城市id
        request("/Base/getPlaceInfo", {
          cityname: city
        }, function (json) {
          if (json.code == 0) {
            log("城市id刷新成功" + json.data.CityId)
            self.CityId = json.data.CityId
            baseStorage.setItem(keyname, keyname_cityid, self.CityId);
          }
        });
      }

      baseStorage.setItem(keyname, keyname_lon, self.Lon);
      baseStorage.setItem(keyname, keyname_lat, self.Lat);
      baseStorage.setItem(keyname, keyname_province, self.Province);
      baseStorage.setItem(keyname, keyname_city, self.City);
      baseStorage.setItem(keyname, keyname_district, self.District);
      baseStorage.setItem(keyname, keyname_addresses, self.Addresses);
      baseStorage.setItem(keyname, keyname_timestamp, self.Position);
      baseStorage.setItem(keyname, keyname_position, self.Timestamp);

      self.log();
    };

    self.refreshCityId = function (cityid) {
      baseStorage.setItem(keyname, keyname_cityid, cityid);
    };

    //定时刷新位置信息
    self.timeRefresh = function (interval) {
      interval = interval || 0;
      if (interval == 0) { //只刷新一次
        plus.geolocation.getCurrentPosition(function (position) {
          self.refreshData(position);
          log('位置信息++++：' + JSON.stringify(position));
          plus.storage.setItem('location', true);
        }, function (e) {
          var btnArray = ['否', '是'];
          mui.confirm('定位失败，是否请手动选择城市?', '', btnArray, function (e) {
            if (e.index == 1) {
              openNew('index/citySelect.html');
            } else {
              if (!plus.storage.getItem('whether')) {
                //取消手动定位，默认设置上海
                var posi = {
                  "coordsType": "wgs84",
                  "address": {
                    "district": "徐汇区",
                    "country": "中国",
                    "street": "桂平路",
                    "city": "上海市",
                    "streetNum": "415号"
                  },
                  "addresses": "桂平路415号",
                  "coords": {
                    "latitude": 31.16612421590823,
                    "longitude": 121.3995927625786,
                    "accuracy": 65,
                    "altitude": 61.54365158081055,
                    "heading": null,
                    "speed": null,
                    "altitudeAccuracy": 10
                  },
                  "timestamp": 1506496454842.604
                };
                plus.storage.setItem('location', false);
                self.refreshData(posi);
                mui.fire(plus.webview.getWebviewById('index/home.html'), "citySelect", {
                  city: '上海市'
                });
              }
            }
          })
        }, {
          geocode: true
        });
      } else if (interval > 0) { //每隔几秒刷新一次
        var timer = setInterval(function () {
          plus.geolocation.getCurrentPosition(function (position) {
            self.refreshData(position);
            log('位置信息++++：' + JSON.stringify(position));
            plus.storage.setItem('location', true);
            if (storageUser.UId > 0) {
              request("/Player/savePlayerLonLat", {
                playerid: storageUser.UId,
                lon: position.coords.longitude,
                lat: position.coords.latitude
              }, function (json) {
                log("位置更新成功，" + JSON.stringify(json))
              });
            }
          }, function (e) {

          }, {
            geocode: true
          });
        }, interval);
      }
    }
  }

  function init(_self) {
    _self.Lon = baseStorage.getItem(keyname, keyname_lon) || "";
    _self.Lat = baseStorage.getItem(keyname, keyname_lat) || "";
    _self.Province = baseStorage.getItem(keyname, keyname_province) || "";
    _self.City = baseStorage.getItem(keyname, keyname_city) || "";
    _self.District = baseStorage.getItem(keyname, keyname_district) || "";
    _self.Addresses = baseStorage.getItem(keyname, keyname_addresses) || "";
    _self.Position = baseStorage.getItem(keyname, keyname_position) || "";
    _self.Timestamp = baseStorage.getItem(keyname, keyname_timestamp) || "";
    _self.CityId = baseStorage.getItem(keyname, keyname_cityid) || "";
  }
  //单例实例
  var instance;
  //返回对象
  return {
    getInstance: function (args) {
      //if(instance === undefined) {
      //log("一个心得")
      instance = new singlekidstoragelocation(args);
      //}
      return instance;
    }
  };
})();
//用户搜索数据缓存
var kidstoragesearchhistory = (function () {

  var keyname = "searchhistory";

  function singlekidstoragesearchhistory(field) {
    var self = this;
    self.list = function () {
      var jsonstr = baseStorage.getItem(keyname, field) || "{}";
      return JSON.parse(jsonstr);
    };
    self.update = function (val) {
      val = val.trim();
      var jsonstr = baseStorage.getItem(keyname, field) || "{}";
      var _list = JSON.parse(jsonstr);
      if (_list && _list.length > 0) {
        var index = -1;
        var item;
        for (var i = 0; i < _list.length; i++) {
          item = _list[i];
          if (item == val) {
            index = i;
          }
        }
        if (index == -1) { //不存在，加到第一个位置上
          _list.unshift(val);
        } else { //存在，移动到首位
          _list.splice(index, 1);
          _list.unshift(val);
        }
        if (_list.length > 10) { //删除第11个
          _list.pop();
        }
        baseStorage.setItem(keyname, field, JSON.stringify(_list));
      } else {
        _list = [];
        _list.push(val);
        jsonstr = JSON.stringify(_list);
        baseStorage.setItem(keyname, field, jsonstr);
      }
    };
    self.clear = function () {
      baseStorage.removeItem(keyname, field);
    };
  }
  //单例实例
  var instance;

  //返回对象
  return {
    getInstance: function (field) {
      instance = new singlekidstoragesearchhistory(field);
      return instance;
    },
    clear: function () {
      baseStorage.removeItem(keyname);
    }
  }
})();
//全部搜索历史对象
var appSearchHistory = {
  //搜索朋友
  searchFriends: kidstoragesearchhistory.getInstance("searchfriendhistory"),
  //搜索赛事
  searchMatch: kidstoragesearchhistory.getInstance("searchmatchhistory"),
  //搜索城市
  searchCity: kidstoragesearchhistory.getInstance("searchcityhistory"),
  //搜索战帖
  searchFight: kidstoragesearchhistory.getInstance("searchFighthistory"),
  //搜索新闻
  searchNews: kidstoragesearchhistory.getInstance("searchnewshistory"),
  //搜索店铺
  searchShop: kidstoragesearchhistory.getInstance("searchShophistory"),
  //搜索附近的人
  searchPeople: kidstoragesearchhistory.getInstance("searchPeoplehistory"),
  //首页搜索
  searchHome: kidstoragesearchhistory.getInstance("searchhomehistory"),
  //搜索论坛
  searchBbs: kidstoragesearchhistory.getInstance("searchbbshistory")
}

//公共js文件

var PAY_DOMAIN = ''

/**
 * 打印日志
 */

function log(data) {
  if (debug) {
    if (typeof (data) == "object") {
      console.log(JSON.stringify(data)); //console.log(JSON.stringify(data, null, 4));
    } else {
      console.log(data);
    }
  }
}