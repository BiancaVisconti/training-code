import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WebflixModule } from './webflix/webflix.module';


const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes), WebflixModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
