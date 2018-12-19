
//当前页
var PageIndex = 1;
//总页数
var PageCount = 0;
//每页显示条数
var PageSize = 5;
//首页
function Frist() {
    PageIndex = 1;
    Show();
}
//尾页
function List() {
    PageIndex = PageCount;
    Show();
}
//上一页
function Prve() {
    if (PageIndex <= 1) {
        alert("这是第一页");
        return;
    }
    PageIndex--;
    Show();
}

//下一页
function Next() {
    if (PageIndex >= PageCount) {
        alert("这是最后一页");
        return;
    }
    PageIndex++;
    Show();
}
//跳转页面
function Tiao() {

    if ($("#T1").val() < 1 || $("#T1").val() > PageCount) {
        alert("不存在该页数");
        PageIndex = 1;
        $("#T1").val("");

        //----显示方法Show()
        Show();

        return;
    }

    PageIndex = $("#T1").val();

    //----显示方法Show()
    Show();

}

//<div>
//    <a href="#" onclick="Frist()">首页</a>
//    <a href="#" onclick="Prve()">上一页</a>
//    <label id="PageCount" style="margin:0px 10px;"></label>
//    <a href="#" onclick="Next()">下一页</a>
//    <a href="#" onclick="List()">尾页</a>
//    <label>第</label><input type="text" id="T1" onclick='Tiao()' style="width:30px" /><label>页</label><input type="button" value="跳转页面" id="TiaoPage" />
//</div>

///文本-总页数
// $("#PageCount").text("当前总页数：" + PageCount);

//回车键执行事件
//$("input").keydown(function (e) {//当按下按键时
//    if (e.which == 13) {//.which属性判断按下的是哪个键，回车键的键位序号为13
//        $('button.searchBtn').trigger("input");//触发搜索按钮的点击事件
//
//      }
//       })

