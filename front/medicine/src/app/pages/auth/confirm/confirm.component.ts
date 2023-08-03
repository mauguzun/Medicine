import { LoginData } from './../../../../shared/models/ViewModel/LoginData';
import { ApiAuthService } from "src/app/shared/services/api/api-auth.service";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Router } from "@angular/router";

@Component({
  selector: "app-confirm",
  templateUrl: "./confirm.component.html",
  styleUrls: ["./confirm.component.less"],
})
export class ConfirmComponent implements OnInit {

  public loader = false;
  public user : LoginData = new LoginData();

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private authService: ApiAuthService
  ) {}

  ngOnInit() {
    this.route.params.subscribe((url) => {

      this.user.Email = url.email;
    });
  }
  async confirm() {

    this.authService.confirm(this.user);
  }
}
