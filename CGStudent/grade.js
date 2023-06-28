function renderGrade() {
    $.ajax({
        url: "https://localhost:7169/api/Grade",
        method: "GET",
        success: function (data) {
            let htmls = data.map(function (item) {
                return `
                <tr>
                    <td>${item.gradeId}</td>
                    <td>${item.gradeName}</td>
                    <td>
                        <a href='student.html?gradeid=${item.gradeId}'>${item.students.length}</a>
                    </td>
                    <td>${item.completed}</td>
                </tr>
                `
            })
            $('#tbGrade').append(htmls.join(''));
        }
    })
}

function createGrade() {
    let createObj = {
        "gradeName": $("#gradeName").val(),
        "completed": $("#completed").is(":checked")
    }
    $.ajax({
        url: "https://localhost:7169/api/Grade",
        method: "POST",
        contentType: "application/json",
        data: JSON.stringify(createObj),
        success: function (result) {
            if (result.success) {
                alert(result.message)
                let payload = result.payload;
                $('#tbGrade').append(`
                                        <tr>
                                            <td>${payload.gradeId}</td>
                                            <td>${payload.gradeName}</td>
                                            <td>
                                                <a href='student.html?gradeid=${payload.gradeId}'>${payload.students ? payload.students.length : 0}</a>
                                            </td>
                                            <td>${payload.completed}</td>
                                        </tr>
                                        `);
            }
            else {
                alert(result.message)
            }
        }
    })
}

renderGrade()