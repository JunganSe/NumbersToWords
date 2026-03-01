import { defineConfig } from "vite";

// https://vitejs.dev/config/
export default defineConfig({
    server: {
        port: 5173,
        open: true, // auto-open browser on "npm run dev".
    },
    preview: {
        open: true, // auto-open browser on "npm run preview".
    },
    build: {
        outDir: "dist",
        sourcemap: true,
    }
});