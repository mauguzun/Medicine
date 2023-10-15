import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { TranslateService } from '@ngx-translate/core';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  private settings: {
    duration: 3000;
  } | undefined;

  constructor(
    private _snackBar: MatSnackBar,
    private translate: TranslateService
  ) {}

  show(message: string): void {
    this._snackBar.open(this.translate.instant(message),     this.translate.instant("agreed"), this.settings);
  }

  dialog(message: string): void {
    this._snackBar.open(
      message,
      this.translate.instant("agreed"),
      this.settings
    );
  }

  error(message: string): void {
    this._snackBar.open(
      message,
      this.translate.instant("agreed"),
      this.settings
    );
  }

  errorList(errorList: string[], extraMessage = ""): void {
    console.log(errorList);
    // this._snackBar.open(
    //   errorList.join('-'),
    //   null,
    //   null
    // );
  }

}
