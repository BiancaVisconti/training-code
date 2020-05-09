export function success(res) {
    let textarea = document.querySelector("#response");
    res.json().then(function (data) {
        let obj = {
            detail: "null",
            name: "null",
            mass: 0
        };
        obj = data;
        textarea.value = obj;
        console.log(obj);
    }, function (error) {
        textarea.value = "ERROR";
    });
}
export function failure(res) {
    let textarea = document.querySelector("#response");
    textarea.value = "ERROR";
}
