$(document).ready(function () {
    $("input[type='radio']").click(function () {
        var questionValue = $("input[name='qAnswers']:checked").val();
        if (questionValue == model.correctAnswer) {
            $("input[name='qAnswers']:checked").css("background-color", "green");
        }
    });

});