namespace GujLens.Models;

/// <summary>
/// Application settings stored in JSON config.
/// </summary>
public class AppSettings
{
    /// <summary>
    /// Google Cloud Vision API key for image/logo detection.
    /// </summary>
    public string? GoogleVisionApiKey { get; set; }

    /// <summary>
    /// Google Cloud Translation API key.
    /// </summary>
    public string? GoogleTranslationApiKey { get; set; }

    /// <summary>
    /// Target language for translation (ISO 639-1 code, e.g., "en", "de", "es").
    /// </summary>
    public string? TargetLanguage { get; set; }

    /// <summary>
    /// Default save directory for screenshots.
    /// </summary>
    public string? DefaultSaveDirectory { get; set; }

    /// <summary>
    /// Whether to use Tesseract OCR locally instead of Google Cloud Vision.
    /// </summary>
    public bool UseLocalTesseract { get; set; } = false;

    /// <summary>
    /// Path to Tesseract data files (if using local OCR).
    /// </summary>
    public string? TesseractDataPath { get; set; }

    /// <summary>
    /// Keyboard shortcut to trigger screenshot capture.
    /// </summary>
    public string? CaptureShortcut { get; set; } = "PrintScreen";
}