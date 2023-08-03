import { LoginData } from "./../../../../shared/models/ViewModel/LoginData";
import { ApiAuthService } from "./../../../../shared/services/api/api-auth.service";
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.less"],
})
export class LoginComponent implements OnInit {
  form: FormGroup;
  loader = false;

  constructor(private apiAuthService: ApiAuthService, private router: Router) {
    //todo
  }
  ngOnInit() {
    this.form = new FormGroup({
      Email: new FormControl(null, [Validators.required, Validators.email]),

      Password: new FormControl(null, [Validators.required]),
    });
  }
  submit() {
    if (this.form.valid) {
      this.loader = true;
      const user = new LoginData();
      Object.assign(user, this.form.value);

      this.apiAuthService.login(user).then(() => {
       // this.loader = false;
      });
    }
  }
}
