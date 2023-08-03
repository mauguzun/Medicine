import { ApiAuthService } from "./../../../../shared/services/api/api-auth.service";
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { LoginData } from "src/app/shared/models/ViewModel/LoginData";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ["./register.component.less"],
})
export class RegisterComponent implements OnInit {
  form: FormGroup;
  loader = false;

  constructor(private apiAuthService: ApiAuthService) {}

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
      this.apiAuthService.register(user).then(data=>{
        this.loader = false;
      })
    }
  }
}
