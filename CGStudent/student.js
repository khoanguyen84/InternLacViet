function renderStudent(){
    let url = window.location.href;
    let id = url.substring(url.indexOf('=') + 1, url.length);
    $.ajax({
        url: `https://localhost:7169/api/Grade/${id}`,
        method: "GET",
        success: function (data) {
            let htmls = data.students.map(function (student) {
                return `
                <tr>
                    <td>${student.studentId}</td>
                    <td>${student.fullName}</td>
                    <td>${student.email}</td>
                </tr>
                `
            })
            $('#tbStudent').append(htmls.join(''));
        }
    })
}

renderStudent();