import { Language } from "../../enums/Language";

export class TokenData {
  Email!: string;
  Id!: string;
  Language:Language = Language.en;
  Name!: string;
  TimeZone!: string;
  Group!: string;
  IsMan: boolean = true;
  BirthDay!: Date;
  PhoneNumber!: string;
}

