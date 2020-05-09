import { success, failure } from './handler';

export default class EventHandler {
  Click(event: any) {
    event.stopPropagation(); //event bubbling

    console.log(event.target.id); //event capturing
    let btn: string = event.target.id;

    switch (btn) {
      case "btn-people":
        let text: any = document.querySelector("#people");

        fetch(`https://swapi.co/api/people/${text.value}`).then(
          success, 
          failure
        );
        break;

      default:
        break;
    }
  }
}

