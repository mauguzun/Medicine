import { Language } from "src/app/shared/enums/Language";
import { Sex } from "src/app/shared/enums/Sex";
import { TimeZone } from "src/app/shared/enums/Timezone";
import { SystemRole } from "../../enums/SystemRole";

export class UserResponse {
  birthday?: Date;
  sex?: Sex;
  language!: Language;
  name?: string;
  timeZone!: TimeZone;
  role!: SystemRole;
  id!: number;
  userName?: string;
  normalizedUserName?: string;
  email?: string;
  normalizedEmail?: string;
  emailConfirmed!: boolean;
  passwordHash?: string;
  phoneNumber?: string;
  phoneNumberConfirmed!: boolean;
  accessFailedCount!: number;

}
