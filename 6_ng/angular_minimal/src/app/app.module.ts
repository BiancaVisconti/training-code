  
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppComponent } from "./app.component";
import { NavigatorModule } from "./navigator.module";
import { RouterModule } from "@angular/router";

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, NavigatorModule, RouterModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}