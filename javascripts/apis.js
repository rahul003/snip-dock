jQuery(document).ready(function($) {

$("#dynamic").append('<iframe src="http://ghbtns.com/github-btn.html?user=rahul003&repo=snip-dock&type=watch&count=true&size=large" allowtransparency="true" frameborder="0" scrolling="0" width="170" height="30"></iframe>');


var gitdl,sourceforgedl,softpediadl;
$.ajax({
    url: "https://api.github.com/repos/rahul003/snip-dock/releases",
    dataType: 'jsonp',
    success: function(results){ 
        gitdl = results.data[0].assets[0].download_count;
        console.log(gitdl);
        $("#dynamic").append("<a><span class='octicon octicon-cloud-download'>Downloads: On github : "+ gitdl+"</span></a>");
    	
    }
});




});  

