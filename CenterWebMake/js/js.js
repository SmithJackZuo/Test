/**
 * Created by Administrator on 2017/7/21/0021.
 */
$(document).ready(function() {
    function time() {
        var date = new Date();
        var n = date.getFullYear();
        var y = date.getMonth()+1;
        var t = date.getDate();
        var h = date.getHours();
        var m = date.getMinutes();
        var s = date.getSeconds();

        $('.sj span').eq(0).html(n);
        $('.sj span').eq(1).html(y);
        $('.sj span').eq(2).html(t);
        $('.sj span').eq(3).html(h);
        $('.sj span').eq(4).html(m);
        $('.sj span').eq(5).html(s);
        for (var i = 0; i < $('div').length; i++) {
            if ($('div').eq(i).text().length == 1) {
                $('div').eq(i).html(function(index, html) {
                    return 0 + html;
                });
            }
        }
    }
    time();
    setInterval(time, 1000);
});
/* 新闻图片 */
var ary = location.href.split("&");
jQuery(".slideBox").slide( { mainCell:".bd ul", effect:ary[1],autoPlay:ary[2],trigger:ary[3],easing:ary[4],delayTime:ary[5],mouseOverStop:ary[6],pnLoop:ary[7] });
var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");
document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3Fa630f96b6a9dd549675d26373853f7f1' type='text/javascript'%3E%3C/script%3E"));
/* 成果展示 */
jQuery(".picMarquee-left").slide({mainCell:".bd ul",autoPlay:true,effect:"leftMarquee",vis:5,interTime:50,trigger:"click"});
var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");
document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3Fa630f96b6a9dd549675d26373853f7f1' type='text/javascript'%3E%3C/script%3E"));

// 幻灯片
var
    $item = $(".carousel-inner .item");
$Titlenews=$(".Titlenews");
$btn = $(".carousel-btn .btn");
$prev = $(".carousel .prev");
$next = $(".carousel .next");
i = 0;
// 默认
// 幻灯片以及小按钮的变换规则
function slide(num){
    $item.eq(num).fadeIn("fast").css({"display":"block"});
    $item.not($item.eq(num)).fadeOut("fast");
    $btn.eq(num).addClass("active");
    $btn.not($btn.eq(num)).removeClass("active");
    $Titlenews.eq(num).css("display","block");
    $Titlenews.not($Titlenews.eq(num)).css("display","none");
}
// 小按钮设置
$btn.on("click",function(){
    i = $(this).index();
    slide(i);
});
// 上一个
$prev.on("click",function(){
    i <= -5 ? i = 0 : i = i - 1;
    slide(i);
});
// 下一个
$next.on("click",function(){
    i >= 5 ? i = 0 : i++;
    slide(i);
});
// 幻灯片自动播放
function car(){
    cartime = setInterval(function(){
        i >= 5 ? i = 0 : i++;
        slide(i);
    },5000);
}
car();
// 鼠标悬停
$(".carousel").hover(function(){
    clearInterval(cartime);
},car)
