$('#submitGrades').click(function () {
    total = (
        parseInt($('#assignments').val())
        + parseInt($('#quizzes').val())
        + parseInt($('#projects').val())
        + parseInt($('#intex').val())
        + parseInt($('#exams').val())
        + parseInt($('#extra').val())
    ) / 6
    alert(total)

    if (total >= 94) {
        $('#letterGrade').append('A')
    }
    else if (total >= 90) {
        $('#letterGrade').append('A-')
    }
    else if (total >= 87) {
        $('#letterGrade').append('B+')
    }
    else if (total >= 84) {
        $('#letterGrade').append('B')
    }
    else if (total >= 80) {
        $('#letterGrade').append('B-')
    }
    else if (total >= 77) {
        $('#letterGrade').append('C+')
    }
    else if (total >= 74) {
        $('#letterGrade').append('C')
    }
    else if (total >= 70) {
        $('#letterGrade').append('C-')
    }
    else if (total >= 67) {
        $('#letterGrade').append('D+')
    }
    else if (total >= 64) {
        $('#letterGrade').append('D')
    }
    else if (total >= 60) {
        $('#letterGrade').append('D-')
    }
    else if (total < 60) {
        $('#letterGrade').append('E')
    }

    $('#letterGrade').fadeIn()
})