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

renderGrade()