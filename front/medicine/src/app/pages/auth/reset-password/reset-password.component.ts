import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.less']
})
export class ResetPasswordComponent implements OnInit {


  form: FormGroup;
  load = false;

  constructor() { }

  ngOnInit() {


    this.form = new FormGroup({


      email: new FormControl(null, [
        Validators.required,
        Validators.email,
      ]),




    });
  }
  submit() {
    if (this.form.valid) {
      this.load = true;

    }
  }
}
