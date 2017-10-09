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
