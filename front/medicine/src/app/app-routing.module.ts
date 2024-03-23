import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthLayoutComponent } from './pages/auth/auth-layout.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { MainLayoutComponent } from './pages/main/main-layout.component';
import { environment } from 'src/assets/environments/environment';
import { SettingsComponent } from './pages/main/settings/settings.component';
import { AuthGuard } from './shared/auth.guard';
import { DoctorSearchComponent } from './pages/main/doctors/doctor-search/doctor-search.component';

const routes: Routes = [
  {
    path: "",
    component: AuthLayoutComponent,
    children: [
      { path: "", component: LoginComponent  },
    ],
  },
  {
    path: environment.backUrl,
    canActivate: [AuthGuard],
    component: MainLayoutComponent,
    children: [
      { path: "settings", component: SettingsComponent },
      { path: "doct", component: DoctorSearchComponent },
    ],
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
