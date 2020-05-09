  
function clickEvent(event) {
  event.stopPropagation(); //event bubbling

  console.log(event.target.id); //event capturing
  let btn = event.target.id;

  switch (btn) {
    case "btn-people":
      let text = document.querySelector("#people");

      fetch(`https://swapi.co/api/people/${text.value}`).then(success, failure);
      break;

    default:
      break;
  }
}