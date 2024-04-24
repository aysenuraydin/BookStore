$(document).ready(function(){
    
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

    $(".fa-fa").click(function(){  
        console.log("tıkladın!!!");
        return false;
      });

});
  