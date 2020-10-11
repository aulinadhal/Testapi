$('#submit').on('click', function(){
    var name = $('#name').val();
    var oData = {
        Name : name
    }
    $.ajax({
       url :'https://localhost:5001/Name/Save',
        type :'POST',
        contentType: 'application/json',
       data: oData,
        success: function(result){
            alert('api is hit!');
        },
       error: function(){
            alert('something went wrong!');
        }
    })
})