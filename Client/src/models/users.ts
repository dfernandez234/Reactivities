export interface User {
    displayName: string;
    token: string;
    username: string;
    image?: string;
    bio?: string;
}

export interface registerRequest{
    email: string;
    password: string;
    displayName?: string;
    username?: string;
}

export interface LoginRequest{
    email: string;
    password: string;
}