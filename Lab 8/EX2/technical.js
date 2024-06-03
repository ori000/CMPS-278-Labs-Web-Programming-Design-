$(document).ready(function()
{
//function maximize()
//{
    $("#button").click(function(){
    $("#square").animate({
    height: "500px",
    width: "500px"
    }, 1500 ); // how long the animation should be
    $("#square").css('background-color', 'red');
    });
//}
//function minimize()
//{
    $("#reset").click(function(){
    $("#square").animate({
        height: "200px",
        width: "200px"
    }, 1500 ); // how long the animation should be
    $("#square").css('background-color', 'blue');
    });
//}
});