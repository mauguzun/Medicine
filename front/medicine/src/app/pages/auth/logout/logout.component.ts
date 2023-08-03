import { Component, OnInit } from "@angular/core";
import { ApiAuthService } from "src/app/shared/services/api/api-auth.service";

@Component({
  selector: "app-logout",
  templateUrl: "./logout.component.html",
})
export class LogoutComponent {
  constructor(private apiAuthService: ApiAuthService) {
    apiAuthService.logout();
  }
}
