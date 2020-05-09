import Result from "./result";

export function success (res: Response) {
  let textarea: any = document.querySelector("#response");

  res.json().then(
    function (data: Result) {
      let obj: Result = {
        detail: "null",
        name: "null",
        mass: 0
      };

      obj = data;

      textarea.value = obj;
      console.log(obj);
    },
    function (error) {
      textarea.value = "ERROR";
    }
  );
}

export function failure (res: Response) {
  let textarea: any = document.querySelector("#response");

  textarea.value = "ERROR";
}