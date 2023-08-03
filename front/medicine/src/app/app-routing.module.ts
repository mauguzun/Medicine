import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthLayoutComponent } from './pages/auth/layout/auth-layout.component';
import { ConfirmComponent } from './pages/auth/confirm/confirm.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { LogoutComponent } from './pages/auth/logout/logout.component';
import { RegisterComponent } from './pages/auth/register/register.component';

const routes: Routes = [
  // {
  //   path: "",
  //   component: LoginedLayoutComponent,
  //   canActivate: [AuthGuard],
  //   children: [

  //   ], 

  // },
  {
  path: "auth",
  component: AuthLayoutComponent,
  children: [
    { path: "register", component: RegisterComponent },
    { path: "login", component: LoginComponent },
    { path: "logout", component: LogoutComponent },
    { path: "confirm/:email", component: ConfirmComponent },
  ]},];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
