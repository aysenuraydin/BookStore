$(document).ready(function(){
    $("i").css("color","red");
    $(window).scroll(function(){
       if($(window).scrollTop()>10){
           $(".backtotop").fadeIn();
       }
       else{
           $(".backtotop").fadeOut();
       }  
    });
    $(".backtotop").click(function(){  
      $("html,body").animate({scrollTop:0},700);
      return false;
    });
});
  