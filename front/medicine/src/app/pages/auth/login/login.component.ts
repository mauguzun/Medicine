import { HttpResponse } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { TranslateService } from "@ngx-translate/core";
import { ApiResponse,TupleReponse } from "src/app/shared/models/viewModels/ApiResponse";
import { LoginDto } from "src/app/shared/models/viewModels/Dto/LoginDto";
import { UserSettingsDto } from "src/app/shared/models/viewModels/Dto/UserSettingsDto";
import { AuthService } from "src/app/shared/services/api/auth.service";
import { NotificationService } from "src/app/shared/services/notification.service";
import { environment } from "src/assets/environments/environment";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.less"],
})

export class LoginComponent implements OnInit {
  
  form: FormGroup = new FormGroup({
    Email: new FormControl(null, [Validators.required, Validators.email]),
    Password: new FormControl(null, [Validators.required]),
  });

  loader = false;

  constructor(private authService: AuthService,
     private router: Router, private notification: NotificationService, private translate: TranslateService) {
  }

  ngOnInit() { }

  submit() {

    if (this.form.valid) {

      this.loader = true;
      const user = new LoginDto();
      Object.assign(user, this.form.value);

      this.authService.login(user)
        .subscribe((response: HttpResponse<ApiResponse<TupleReponse<string, UserSettingsDto>>>) => {
          this.loader = false;
          if (response.ok === true) {
            this.router.navigate([`/${environment.backUrl}/settings`])
          } else if (response.body) {
            this.notification.error(response.body.Message.Item1);
          }
        })
    }
  }
}
