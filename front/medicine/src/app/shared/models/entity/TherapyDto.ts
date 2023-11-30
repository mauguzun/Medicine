import { TherapyStatus } from "../../enums/TherapyStatus";
import { TherapyType } from "../../enums/TherapyType";
import { User } from "./User";
import { TranslatedDto } from "./translate/TranslatedDto";
import { CourseDto } from "./CourseDto";



export class TherapyDto {
  courses: CourseDto[] = [];
  translations: TranslatedDto[] = [];
  userId!: number;
  status!: TherapyStatus;
  type!: TherapyType;
  title?: string;
  description?: string;
  user?: User;
  id!: number;
  createdAt?: Date;
}
