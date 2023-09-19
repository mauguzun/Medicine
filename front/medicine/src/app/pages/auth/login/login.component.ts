import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { first } from "rxjs";
import { ApiResponse } from "src/app/shared/models/viewModels/ApiResponse";
import { LoginData } from "src/app/shared/models/viewModels/LoginData";
import { AuthService } from "src/app/shared/services/auth.service";

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

  constructor(private authService: AuthService, private router: Router) {

  }

  ngOnInit() { }

  submit() {

    if (this.form.valid) {

      this.loader = true;
      const user = new LoginData();
      Object.assign(user, this.form.value);

      this.authService.login(user)
        .subscribe ((resp : ApiResponse<string>) => {
          if (resp.Error === true) {
            alert(111)

          } else {
            alert(1)
          }
        })



    }
  }
}
