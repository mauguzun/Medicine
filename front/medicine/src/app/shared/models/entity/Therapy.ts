import { TherapyType } from "../../enums/TherapyType";
import { TherapyStatus } from "../../enums/TherapyStatus";
import { User } from "./User";
import { Course } from "./Course";
import { TranslatedTherapy } from "./translate/TranslatedTherapy";

export class Therapy {
  userId!: number;
  status!: TherapyStatus;
  type!: TherapyType;
  courses: Course[] = [];
  translations: TranslatedTherapy[] = [];
  user?: User;
  id!: number;
  createdAt?: Date;
}
