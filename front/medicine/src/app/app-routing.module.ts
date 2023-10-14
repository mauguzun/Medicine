import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthLayoutComponent } from './pages/auth/auth-layout.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { MainLayoutComponent } from './pages/main/main-layout.component';
import { environment } from 'src/assets/environments/environment';
import { SettingsComponent } from './pages/main/settings/settings.component';

const routes: Routes = [
  {
    path: "",
    component: AuthLayoutComponent,
    children: [
      { path: "", component: LoginComponent },
    ],
  },
  {
    path: environment.backUrl,
    component: MainLayoutComponent,
    children: [
      { path: "settings", component: SettingsComponent },
    ],
  },
];
  
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
