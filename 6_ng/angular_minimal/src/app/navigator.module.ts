import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule, Routes } from "@angular/router";
import { AppComponent } from "./app.component";
import { AlexComponent } from "./alex.component";
import { TangoComponent } from "./tango.component";
import { RandallComponent } from "./randall.component";

const urls: Routes = [
  { path: "", component: AppComponent },
  { path: "alex", component: AlexComponent },
  { path: "randall", component: RandallComponent },
  { path: "tango", component: TangoComponent }
];

@NgModule({
  declarations: [AlexComponent, TangoComponent, RandallComponent],
  imports: [CommonModule, RouterModule.forRoot(urls)],
  exports: [AlexComponent, TangoComponent, RandallComponent]
})
export class NavigatorModule {}