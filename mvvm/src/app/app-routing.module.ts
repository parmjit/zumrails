import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { AdditemComponent } from './additem/additem.component';
import { ShowdataComponent } from './showdata/showdata.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
    },
  {
  path: 'navbar',
  component: NavbarComponent
  },
  {
    path: 'additem',
    component: AdditemComponent
  },
  {
    path:'showdata',
    component: ShowdataComponent
  },
  {
  path:'',
  redirectTo: '/home',
  pathMatch: 'full'
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
