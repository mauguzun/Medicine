import { Language } from "../../enums/Language";
import { CourseDto } from "./CourseDto";
import { User } from "./User";

export class CourseGroupDto {
  courses: CourseDto[] = [];
  title?: string;
  description?: string;
  language: Language = Language.en
  user?: User;
  userId!: number;
  id!: number;
  createdAt!: Date;
}
