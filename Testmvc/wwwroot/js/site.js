// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#writePost').submit(function(e){
    e.preventDefault();
    var post={
        'PostTitle':$('#PostTitle').val(),
        'PostSubTitle':$('#PostSubTitle').val(),
        'PostImageURL':$('#PostImageURL').val(),
        'PostContent':$('#editor .ql-editor').html()
    }
    $.post('/home/post',{post},function(response){
        $('#notification').removeClass('hide').find('p').text(response);
        setTimeout(function(){
             $('#notification').addClass('hide')
        },5000)
        console.info(response)
    })
    })