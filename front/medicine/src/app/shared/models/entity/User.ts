import { Language } from "../../enums/Language";
import { Sex } from "../../enums/Sex";
import { TimeZone } from "../../enums/Timezone";

export class User {
  birthday?: Date;
  sex: Sex = Sex.male;
  language: Language = Language.en;
  name?: string;
  timeZone: TimeZone = TimeZone["(UTC+07:00) Bangkok, Hanoi, Jakarta"];
  id!: number;
  userName?: string;
  normalizedUserName?: string;
  email?: string;
  normalizedEmail?: string;
  emailConfirmed: boolean = false;
  passwordHash?: string;
  securityStamp?: string;
  concurrencyStamp?: string;
  phoneNumber?: string;
  phoneNumberConfirmed: boolean = false;
  twoFactorEnabled: boolean = false;
  lockoutEnd?: Date;
  lockoutEnabled: boolean = false;
  accessFailedCount: number = 0;
}