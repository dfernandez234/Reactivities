import { IActivityCreate } from "./createActivity";

export interface IActivityEdit{
    ActivityId:string | undefined,
    data: IActivityCreate
}