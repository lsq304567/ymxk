/**
 * 参考文档：http://ask.dcloud.net.cn/article/431
 * 升级文件为JSON格式数据，如下：
 *
 * 需升级
 {
	"status":1,
	"version": "2.6.0",
	"title": "Hello MUI版本更新",
	"note": "修复“选项卡+下拉刷新”示例中，某个选项卡滚动到底时，会触发所有选项卡上拉加载事件的bug；\n修复Android4.4.4版本部分手机上，软键盘弹出时影响图片轮播组件，导致自动轮播停止的bug；",
	"url": "http://www.dcloud.io/hellomui/HelloMUI.apk"
}
*
* 无需升级
{"status":0}
 */
// {
//   "appid": "H5291D269",
//   "iOS": {
//     "version": "1.2.0",
//     "title": "Hello MUI版本更新",
//     "note": "修复offcanvas偶发性出现菜单不能自动关闭的问题\n修复offcanvas中输入类控件无法focus的问题\n修复当list数据过多，swipeout菜单引起crash的bug\nhello mui支持双击顶部、列表滚到顶部功能",
//     "url": "itms-services://?action=download-manifest&url=https://d.dcloud.net.cn/hellomui/HelloMUI.plist"
//   },
//   "Android": {
//     "version": "2.4.0",
//     "title": "Hello MUI版本更新",
//     "note": "修复轮播组件和原生滚动冲突的bug；\n修复列表控件不显示上边框的bug；",
//     "url": "http://www.dcloud.io/hellomui/HelloMUI.apk"
//   }
// }
var server = "http://www.dcloud.io/check/update"; //获取升级描述文件服务器地址

function update() {
	mui.getJSON(server, {
		"appid": plus.runtime.appid,
		"version": plus.runtime.version,
		"imei": plus.device.imei
	}, function(data) {
		if (data.status) {
			plus.nativeUI.confirm(data.note, function(event) {
				if (0 == event.index) {
					plus.runtime.openURL(data.url);
				}
			}, data.title, ["立即更新", "取　　消"]);
		}
	});
}

mui.os.plus && !mui.os.stream && mui.plusReady(update);